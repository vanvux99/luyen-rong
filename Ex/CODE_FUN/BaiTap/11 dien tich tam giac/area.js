var result = () => {
    let numA = Number(prompt('Nhập số A: ', ''))
    let numB = Number(prompt('Nhập số B: ', ''))
    let numC = Number(prompt('Nhập số C: ', ''))
    console.log(numA);

    alert('Diện tích của tam giác ABC là: ' + areaOfTriangle(numA, numB, numC))
}

var areaOfTriangle = (a, b, c) => {
    let perimeter = a + b + c
    let p = perimeter / 2

    if (a <= 100 && b <= 100 && c <= 100) {
        return Math.sqrt(p * ((p - a) * (p - b) * (p - c)))
    }
}

result()