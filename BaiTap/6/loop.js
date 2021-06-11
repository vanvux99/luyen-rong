var numInput = prompt('Nhập vào chuỗi cần đảo ngược', '')
const lENGTH_NUMBER = numInput.length

var result = () => {
    console.warn("mảng trả về", splitArray());
    console.warn("mảng đảo ngược", reverseArray());
}

var splitArray = () => {
    let arraryReturn = new Array()
    let num = numInput

    // tách chuỗi thành từng phần tử, sau đó thêm vào mảng
    for (let index = 0; index < lENGTH_NUMBER; index++) {
        let temp = num.substring(0, 1)
        num = num.substring(1)
        arraryReturn.push(temp)
    }

    return arraryReturn
}

var reverseArray = () => {
    let numArrary = new Array()
    for (let index = lENGTH_NUMBER - 1; index >= 0; index--) {
        numArrary.push(splitArray()[index])
    }

    return numArrary
}

