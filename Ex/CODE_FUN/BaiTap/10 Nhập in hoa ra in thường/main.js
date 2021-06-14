var result = () => {
    nhap()
    alert(inra())
}

function nhap() {
    let charInput = prompt('Nhập vào chữ cái in hoa: ', '')

    return charInput
}

var inra = () => {
    let numDEC = nhap().charCodeAt(0)
    let charOutput = String.fromCharCode(numDEC + 31)

    return charOutput
}


