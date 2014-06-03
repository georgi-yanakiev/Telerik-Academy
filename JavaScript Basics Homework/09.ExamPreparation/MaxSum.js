function Solve(params) {
    var N = parseInt(params[0]);
    var currentSum = parseInt(params[1]);
    var maxSum = parseInt(params[1]);

    for (var i = 2; i < N; i++) {
        if (currentSum < 0) {
            currentSum = parseInt(params[i]);
        } else {
            currentSum += parseInt(params[i]);
        }
        if (currentSum > maxSum) {
            maxSum = currentSum;
        }
    }
    return (maxSum);
}

var params = ["8", "1", "6", "-9", "4", "4", "-2", "10", "-1"];
console.log(Solve(params));
