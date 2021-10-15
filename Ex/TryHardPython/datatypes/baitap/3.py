# 3, Sắp xếp mảng tăng / giảm dần bằng Python
#     Hãy viết chương trình Python sắp xếp các phần tử trong mảng theo thứ tự tăng dần và giảm dần, 
#     danh sách các phần tử do người dùng nhập vào và đó phải là danh sách các số nguyên.


def nhapmang():
    global mang
    while True:
        try:    
            nhap = input('nhap phan tu mang: ')
            if nhap == 'thoat':
                break
            mang.append(int(nhap))
        except:
            print('lỗi nhập')

def mangtangdan(ds):
    global mang
    tam = ''
    for i in range(0, len(mang)):
        for j in range(i+1, len(mang)):
            if mang[i]>mang[j]:
                tam = mang[i]
                mang[i] = mang[j]
                mang[j] = tam

    for i in mang:
        print(i, end =' ')

def manggiamdan(ds):
    global mang
    tam = ''
    for i in range(0, len(mang)):
        for j in range(i+1, len(mang)):
            if mang[i]<mang[j]:
                tam = mang[i]
                mang[i] = mang[j]
                mang[j] = tam

    for i in mang:
        print(i, end =' ')

mang = []
nhapmang()
mangtangdan(mang)
manggiamdan(mang)