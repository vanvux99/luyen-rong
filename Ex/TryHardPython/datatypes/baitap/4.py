# 4, Chương trình quản lý sinh viên Python lưu mảng và dictionary
#   Hãy viết chương trình quản lý sinh viên bằng Python, gồm các chức năng chính như sau:
#       Khởi đầu là danh sách sinh viên rỗng.
#       Thông tin lưu trữ gồm mã sinh viên và tên sinh viên
#       Cho phép người dùng chọn chức năng như sau:
#          1: Thêm sinh viên
#          2: Xóa sinh viên
#          3: Sửa sinh viên
#          4: Xem danh sách sinh viên



def them(ten):
    global danhsachsinhvien
    if bool(danhsachsinhvien) == False:
        danhsachsinhvien['1'] = ten
    else:
        danhsachsinhvien[len(danhsachsinhvien) + 1] = ten

def themsinhvien():
    while True:
        tensv = input('nhập tên sv cần thêm: ')
        if tensv == 'exit':
            break
        them(tensv)

def xoa(id):
    global danhsachsinhvien
    del danhsachsinhvien[id]

def xoasinhvien():
    tensv = input('nhập id sv cần xóa: ')
    xoa(tensv)
    print('đã xóa sv khỏi ds')

def sua(id, tensv):
    global danhsachsinhvien
    for i in danhsachsinhvien:
        if i == id: danhsachsinhvien[i] = tensv

def suasinhvien():
    idsv = input('nhập id sv cần sửa: ')
    tensv = input('nhập ten sv cần sửa: ')
    sua(idsv, tensv)
    print('đã sửa sv')

def xemds():
    global danhsachsinhvien
    for i in danhsachsinhvien:
        print('id:', i, ', tên sinh viên: ', danhsachsinhvien[i])

def kiemtrads():
    global danhsachsinhvien
    if bool(danhsachsinhvien) == False:
        print('danh sách trống')

danhsachsinhvien = {'1': 'vũ'}
kiemtrads()
# themsinhvien()
xemds()
# xoasinhvien()
suasinhvien()
xemds()