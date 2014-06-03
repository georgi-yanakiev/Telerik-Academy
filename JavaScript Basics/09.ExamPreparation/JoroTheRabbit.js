function Solve(args) {
    var input = args[0].split(", ").map(Number),
        bestPath = Number.MIN_VALUE,
        len = input.length;

    for (var startIndex = 0; startIndex < len; startIndex++) {
        for (var step = 1; step < len; step++) {
            var index = startIndex;
            var currentPath = 1;
            var next = 0;
            if ((index + step) >= len) {
                next = (index + step) - len;
            } else {
                next = (index + step);
            }

            while (next != startIndex && input[index] < input[next]) {
                currentPath++;
                index = next;
                if ((index + step) >= len) {
                    next = (index + step) - len;
                } else {
                    next = (index + step);
                }
            }

            if (bestPath < currentPath) {
                bestPath = currentPath;
            }

        }
    }
    return bestPath;
}

var args = ["1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0"];
console.log(Solve(args));
