# In ra các số chẵn trong mảng bằng Python
def sochan(number):
    if int(number) % 2 == 0:
        return True
    
def insochan(list):
    for i in list:
        if sochan(i) == True:
            print(i, end = " ")

def nhapdulieu():
    #nhập dữ liệu đó vào mảng
    #kiểm tra dữ liệu phải là số
    global mangsotunhien
    while True:
        try:
            so = input('nhập số: ')
            if so == 'thoat':
                break
            so = int(so)
            mangsotunhien.append(so)
        except:
            print('kiểm tra lại dữ liệu')

mangsotunhien = []
nhapdulieu()
insochan("các số chẵn trong mảng: ", mangsotunhien)