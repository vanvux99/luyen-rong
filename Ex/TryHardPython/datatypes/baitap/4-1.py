# 4, Chương trình quản lý sinh viên Python lưu mảng và dictionary
#   Hãy viết chương trình quản lý sinh viên bằng Python, gồm các chức năng chính như sau:
#       Khởi đầu là danh sách sinh viên rỗng.
#       Thông tin lưu trữ gồm mã sinh viên và tên sinh viên
#       Cho phép người dùng chọn chức năng như sau:
#          1: Thêm sinh viên
#          2: Xóa sinh viên
#          3: Sửa sinh viên
#          4: Xem danh sách sinh viên



def themsinhvien(tensv):
    global thongtinsv
    global dssv
    thongtinsv['id'] = len(dssv) + 1
    thongtinsv['ten'] = tensv
    dssv.append(thongtinsv)

def suathongtin(id, ten):
    global dssv
    for i in dssv:
        if i['id'] == id: 
            i['ten'] = ten

def xoathongtin(id):
    global dssv
    for i in dssv:
        if i['id'] == id: 
            dssv.remove(i['id'])

def xemds():
    global dssv
    for i in dssv:
        print('id: ',i['id'], 'ten: ', i['ten'])

def hienthichuongtrinh():
    idsv = input('nhập id sv: ')
    tensv = input('nhập tên sv: ')
    # themsinhvien(tensv)
    suathongtin(idsv, tensv)
    xemds()

thongtinsv = {
    'id' : '',
    'ten' : ''
}

dssv = [
    {'id' : 1, 'ten' : 'vũ văn thành'}
]

hienthichuongtrinh()