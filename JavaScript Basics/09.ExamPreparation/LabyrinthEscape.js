function Solve(params) {

    var rowsNCols = params[0].split(" "),
        rows = rowsNCols[0] | 0,
        cols = rowsNCols[1] | 0,
        startPos = params[1].split(" "),
        startRow = startPos[0] | 0,
        startCol = startPos[1] | 0,
        isOut = false,
        isLost = false,
        pathSum = 0,
        numOfCells = 0,
        result;

    var directions = []; // array with directions
    for (var row = 0; row < rows; row++) {
        directions[row] = params[row + 2];
    }


    var numbers = [];
    var counter = 1; // numbers matrix
    for (row = 0; row < rows; row++) {
        numbers[row] = [];
        for (var col = 0; col < cols; col++) {
            numbers[row].push(counter);
            counter++;
        }
    }

    while (!isLost && !isOut) {

        if (startRow < 0 || startRow >= rows || startCol < 0 || startCol >= cols) { // checks if its in
            isOut = true;
            break;
        }


        if (numbers[startRow][startCol] !== false) {
            pathSum += numbers[startRow][startCol];
            numbers[startRow][startCol] = false; // marks the visited cells
            numOfCells++; // number of visited cells

            if (directions[startRow][startCol] === "l") {
                startCol--;
            } else if (directions[startRow][startCol] === "r") {
                startCol++;
            } else if (directions[startRow][startCol] === "u") {
                startRow--;
            } else if (directions[startRow][startCol] === "d") {
                startRow++;
            }

        } else {
            isLost = true;
            break;
        }
    }

    if (isLost) {
        result = "lost " + numOfCells;
    } else {
        result = "out " + pathSum;
    }

    return result;
}

var args = [
    "5 8",
    "0 0",
    "rrrrrrrd",
    "rludulrd",
    "durlddud",
    "urrrldud",
    "ulllllll"
];

console.log(Solve(args));
