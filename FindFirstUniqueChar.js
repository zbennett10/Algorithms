//Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.

var firstUniqChar = function(s) {
    for(var i = 0; i < s.length; i++) {  //iterate over each char
        var char = s[i];
        var searchStr = s.substring(s.indexOf(char) + 1, s.length);  //split the rest into its own string
        if(!(searchStr.includes(char))) return s.indexOf(char); //if the rest has this same char.. we found it!
    }
    return -1; 
};
