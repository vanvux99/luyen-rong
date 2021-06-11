var result = () => {
    var charA = prompt('Nhập chữ cái A: ', '')
    var numN = prompt('Nhập số N: ', '')
    numN = Number(numN)

    if (numN <= 10) {
        let numDEC = charA.charCodeAt(0)
        numDEC = numDEC + numN
        if (numDEC <= 123) {
            numDEC = 97

            confirm(String.fromCharCode(numDEC))
        }
    }
}

result()