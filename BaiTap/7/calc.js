var result = () => {
    let A = prompt('Nhập số A: ', '')
    let B = prompt('Nhập số B: ', '')

    A = Number(A)
    B = Number(B)
    alert(sum(A, B))
}

var sum = (a, b) => {
    return (a <= 1000 && b <= 1000) ? ((a + b) + (a * b)) : 'Giá trị nhập vào sai'
}


result()