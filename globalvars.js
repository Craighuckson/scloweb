class GlobalVars {
    static DRAWMODE = {
        selectTool: 0,
        drawLine: 1,
        drawRoad: 2,
        drawCable: 3,
        drawText: 4,
        undo: 5,
        drawRectangle: 6,
        drawCircle: 7,
        move: 8,
        drawMeasurement: 9,
        drawSymbol: 10,
        drawArc: 11,
        insertSymbol: 12,
        insertText: 13,
        Rotate: 14,
        InsertStamp: 15,
        Resize: 16,
        Clear: 17,
    };
    
    static UNDOSTACK = [];
    //dbConnection = new sqlite3.Database('drawing.db');
    static SAVABLECHANGES = false;
    static USERMODE = DRAWMODE.selectTool;

    static LINESTYLE = {
        solid: 0,
        dashed: 1,
        dotted: 2,
    };
    
    static SHAPETYPE = {
        arc : 0,
        circle : 1,
        line : 2,
        rectangle : 3,
        group : 4,
        stamp : 5,
        text : 6,
        triangle : 7,
    }
    
    static TEXTMODE = {
        horizontal: 0,
        vertical: 1,
    }
    
    
    static Dot(point1, point2) {
        try {
            let result;
            let num = (point1.x * point2.x) + (point1.y * point2.y);
            result = num;
        } catch (ex) {
            alert(ex);
        }
        return result;
    }
    
    
   
    
}