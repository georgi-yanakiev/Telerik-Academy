function Solve(params) {
    var valley = params[0].split(', ').map(Number);
    params = params.slice(2);
    var patterns = [];
    var sumCoins = -Infinity;
    var valleyLength = valley.length;

    for (var i = 0; i < params.length; i++) {
        patterns[i] = params[i].split(', ').map(Number);
    }

    for (var pattern = 0, curPatLen = patterns.length; pattern < curPatLen; pattern++) {
        var position = 0;
        var visited = [];
        var coins = valley[position];
        visited[position] = true;
        var escaped = false;

        while (!escaped) {
            for (var index = 0, patLen = patterns[pattern].length; index < patLen; index++) {
                position = patterns[pattern][index] + position;
                if (position >= valleyLength || position < 0 || visited[position]) {
                    escaped = true;
                    break;
                }
                coins += valley[position];
                visited[position] = true;
            }
        }

        if (coins > sumCoins) {
            sumCoins = coins;
        }

    }
    return sumCoins;
}

var params = ["1, 3, -6, 7, 4, 1, 12",
    "3",
    "1, 2, -3",
    "1, 3, -2",
    "1, -1"
];
console.log(Solve(params));
