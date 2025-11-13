//1
let salaries = {
John: 100,
Ann: 160,
Pete: 130
};

function sum(obj){
    let retval = 0;
    for(person in obj){
        retval += obj[person];
    }
    return retval;
}

console.log(sum(salaries));

//2
function multiplyNumeric(obj){
    for(key in obj){
        if(typeof obj[key] === "number")
            obj[key] *=2;
    }
}
let menu = {
width: 200,
height: 300,
title: "My menu"
};

multiplyNumeric(menu);
console.log(menu);

//3
function checkEmailId(str){
    const regex = /^[^@]+@[^.@]+\..+$/;
    if (typeof str !== "string")
        return false;
    if (!regex.test(str))
        return false;
    return true;
}
console.log(checkEmailId("hello@gmail.c"));

//4
function truncate(str,maxlength){
    if(str.length >= maxlength){
        return str.slice(0,maxlength-1) + "...";
    }
    return str;
}

console.log(truncate("What I'd like to tell on this topic is:", 20));
console.log(truncate("Hi everyone!", 20));

let styles =["James", "Brennie"];
styles.push("Robert");
styles[Math.floor(styles.length/2)] = "Calvin";
console.log(styles.shift());
styles.unshift("Rose", "Regal");
console.log(styles);

