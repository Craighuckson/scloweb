import Rectangle from "./rectangle.js";
import GlobalVars from "./globalvars.js";

class Shape {
    constructor() {
        this.ShapeID = 0;
        this.Colour = 0;
        this.Thickness = 0;
        this.LineStyle = 0;
        this.Visible = false;
        this.BoundingRectangle = new Rectangle();
        this.ShapeType = new GlobalVars.SHAPETYPE();
        this.canSelect = false;
        this.isSelected = false;
    }

    get ShapeID() {
        return this.ShapeID;
    }
    set ShapeID(value) {
        this.ShapeID = value;
    }
    //property Colour

    get Colour() {
        return this.Colour;
    }
    set Colour(value) {
        this.Colour = value;
    }
    //property Thickness

    get Thickness() {
        return this.Thickness;
    }
    set Thickness(value) {
        this.Thickness = value;
    }
    //property LineStyle

    get LineStyle() {
        return this.LineStyle;
    }
    set LineStyle(value) {
        this.LineStyle = value;
    }
    //property Visible

    get Visible() {
        return this.Visible;
    }
    set Visible(value) {
        this.Visible = value;
    }
    
    get BoundingRectangle() {
        return this.BoundingRectangle;
    }

    get ShapeType() {
        return this.ShapeType;
    }

    //property canSelect

    get canSelect() {
        return this.canSelect;
    }
    set canSelect(value) {
        this.canSelect = value;
    }

    //getter isSelected

    get isSelected() {
        return this.isSelected;
    }


}