# 2, Tìm kiếm phần tử trong mảng bằng Python
#     Hãy viết chương trình tìm kiếm dữ liệu trong mảng bằng Python, 
#     cho phép người dùng nhập vào danh sách tên sinh viên, 
#     sau đó tìm kiếm thông tin dựa trên danh sách đó.


def nhaptensinhvien():
    global danhsachtensinhvien
    while True:
        try:
            tensv = input("Nhập họ tên sinh viên: ")
            if tensv == 'thoat':
                break
            danhsachtensinhvien.append(tensv)
        except:
            print('lỗi')

    return danhsachtensinhvien

def timtensinhvien(ten):
    timten = {}
    global danhsachtensinhvien
    for i in range(0, len(danhsachtensinhvien)):
        if danhsachtensinhvien[i] == ten:
            timten[i] = danhsachtensinhvien[i]
    
    if bool(timten) == True:
        for i in timten:
            print('họ tên sv:', timten.get(i), ', vị trí:', i)
    else:
        print('không tìm thấy sinh viên')


danhsachtensinhvien = []
nhaptensinhvien()
ten = input("Nhập tên sinh viên cần tìm: ")
timtensinhvien(ten)