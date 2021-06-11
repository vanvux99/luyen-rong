
var numInput = prompt('Nhập vào chuỗi cần đảo ngược', '')
let stringArray = new Array()

var recursiveString = (str) => {
    return str === '' ? '' : recursiveString(str.substr(1)) + str.charAt(0)
}

alert(recursiveString(numInput))