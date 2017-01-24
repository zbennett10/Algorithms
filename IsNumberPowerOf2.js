//Given an integer, write a function to determine if it is a power of two.

var isPowerOfTwo = function(n) {
    if(n === 1) return true;
    var checker = 2;
    while(checker !== n) {
        if(checker > n) return false;  //we passed our number up....
        checker *= 2; 
    }
    return true;
};
