class DrawingForm {
  //constructor that gets the canvas and initializes it
  static init() {
    canvas = document.getElementById("canvas");
    context = this.canvas.getContext("2d");
    PathAndFileName = "";
    this.ShapeColour = "black";
    this.LineText = "";
    this.SelectedText = "";
    this.DirectionText = "";

    this.setupButtonHandlers();
    context.font = "20px Arial";
    context.fillText("Canvas initialized", 10, 50);
  }

   setupButtonHandlers() {
    let buttons = document.querySelectorAll("button");

    // Loop through all buttons
    buttons.forEach((button) => {
      // Add click event listener to each button
      button.addEventListener("click", function (event) {
        // Handle the click event
        switch (event.target.innerText) {
          case "Exit":
            //change button color to yellow
            alert("exit");
            // Handle Exit button click
            break;

          case "Load Drawing":
            // Handle Load Drawing button click
            alert("load");
            break;
          case "Save Drawing":
            // Handle Save Drawing button click
            break;
          case "Line":
            // Handle Line button click
            break;
          case "Road":
            // Handle Road button click
            break;
          case "Cable":
            // Handle Cable button click
            break;
          case "Text":
            // Handle Text button click
            break;
          case "Insert Image":
            // Handle Insert Image button click
            break;
          case "Symbol":
            // Handle Symbol button click
            break;
          case "Select":
            // Handle Select button click
            break;
          case "Resize":
            // Handle Resize button click
            break;
          case "Rotate":
            // Handle Rotate button click
            break;
          default:
            // Handle unknown button click
            break;
        }
      });
    });
  }
}




export default DrawingForm;
