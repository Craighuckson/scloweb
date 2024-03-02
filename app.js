import DrawingForm from './drawingform.js';

UNDOSTACK = [];
//dbConnection = new sqlite3.Database('drawing.db');
SAVABLECHANGES = false;
USERMODE = DRAWMODE.selectTool

function Point(x, y) {
    this.x = x;
    this.y = y;
}

function dot(point1, point2) {
    try {
        let result;
        let num = (point1.x * point2.x) + (point1.y * point2.y);
        result = num;
    } catch (ex) {
        alert(ex);
    }
    return result;
}

const DRAWMODE = {
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

const LINESTYLE = {
    solid: 0,
    dashed: 1,
    dotted: 2,
};

const SHAPETYPE = {
    arc : 0,
    circle : 1,
    line : 2,
    rectangle : 3,
    group : 4,
    stamp : 5,
    text : 6,
    triangle : 7,
}

const TEXTMODE = {
    horizontal: 0,
    vertical: 1,
}



window.onload = function() {
    DrawingForm.init();
}
