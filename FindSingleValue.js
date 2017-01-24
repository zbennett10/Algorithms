//Given an array of integers, every element appears twice except for one. Find that single one.

//The run time of this is not linear... but what can i say? I like objects.
var singleNumber = function(nums) {
    var numObj = nums.reduce((accumulator, num) => {    
        if(num in accumulator) {
            accumulator[num]++;
        } else {
            accumulator[num] = 1;
        }
        return accumulator;
    }, {});
   
    for(prop in numObj) {
        if(numObj[prop] === 1) return Number(prop);
    }
};
