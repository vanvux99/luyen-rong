var result = () => {
    let charInput = prompt('Nhập vào chữ cái in thường: ', '')
    var numberInput = charInput.charCodeAt(0);
    console.log(numberInput);

    confirm(String.fromCharCode(numberInput - 32))
}

result()