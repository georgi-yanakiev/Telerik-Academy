function Solve(params) {
    var N = parseInt(params[0]);
    var prevNum = Number.MAX_VALUE;
    var seqCount = 0;

    for (var i = 1; i <= N; i++) {
        var currNo = params[i];
        if (currNo < prevNum) {
            seqCount++;
        }
        prevNum = currNo;
    }
    return seqCount;
}

var params = ["6", "1", "3", "-5", "8", "7", "-6"];
console.log(Solve(params));
