function Solve(params) {
    var NMnJumps = params[0].split(" ").map(Number);
    var N = NMnJumps[0];
    var M = NMnJumps[1];
    var noOfjumps = NMnJumps[2];
    var startRow = params[1][0] | 0;
    var startCol = params[1].slice(2) | 0;
    var escaped = false;
    var caught = false;
    var sumOfNums = 0;
    var jumpsOut = 0;

    var jumps = [];
    for (var j = 2; j < params.length; j++) {
        jumps.push(params[j].split(" "));
    }

    var numbers = [];
    var counter = 1; // numbers matrix
    for (row = 0; row < N; row++) {
        numbers[row] = [];
        for (var col = 0; col < M; col++) {
            numbers[row].push(counter);
            counter++;
        }
    }


    while (escaped === false && caught === false) {

        for (var i = 0; i < noOfjumps; i++) {

            if (startRow < 0 || startRow >= N || startCol < 0 || startCol >= M) {
                escaped = true;
                break;
            }

            if (numbers[startRow][startCol] !== false) {

                sumOfNums += numbers[startRow][startCol] | 0;
                numbers[startRow][startCol] = true;
                jumpsOut++;
                startRow += parseInt(jumps[i][0]);
                startCol += parseInt(jumps[i][1]);

            } else {
                caught = true;
                break;
            }
        }
    }
    if (caught) {
        return ("caught " + jumpsOut);
    } else {
        return ("escaped " + sumOfNums);
    }
}

var params = ["6 7 3", "0 0", "2 2", "-2 2", "3 -1"];
console.log(Solve(params));
