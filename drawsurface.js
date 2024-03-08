class DrawingSurface {
    constructor(ctx) {
        this.Shapes = [];
        this.TextIDs = [];
        this.SelectedShapes = [];
        this.GridOn = false;
        this.drawingissaving = false;
        this.context = ctx;
    }

    get Width() {
        //return the html canvas width
        return document.getElementById("canvas").width;
    }

    get Height() {
        return this.context.height;
    }

    Add(Shape) {
        try {
            let num = this.Shapes.length;
            Shape.ShapeID = num;
            this.Shapes[num] = Shape;
            if (Shape.ShapeType === GlobalVariables.ShapeType.Text) {
                this.AddText(Shape);
            }
        } catch (ex) {
            alert(ex)
        }
    }

    AddText(thisText) {
        try {
            let num = this.TextIDs.length;
            this.TextIDs[num] = thisText.ShapeID;
        } catch (ex) {
           alert(ex)
        }
    }

    RemoveText(thisText) {
        try {
            for (let i = 0; i < this.TextIDs.length; i++) {
                if (this.TextIDs[i] === thisText.ShapeID) {
                    this.TextIDs[i] = 0;
                }
            }
        } catch (ex) {
            alert(ex);
        }
    }

    ChangeTextID(oldID, newID) {
        try {
            for (let i = 0; i < this.TextIDs.length; i++) {
                if (this.TextIDs[i] === oldID) {
                    this.TextIDs[i] = newID;
                }
            }
        } catch (ex) {
            alert(ex);
        }
    }
}

export default DrawingSurface;