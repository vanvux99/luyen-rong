# Viết hàm Python tính điểm trung bình học sinh
def diemtrungbinh(toan, li, hoa, van, anh):
    return (toan + li + hoa + van + anh) / 5

hocluc = lambda x:(("yếu" if x < 5 else "trung bình") if x < 7 else "khá") if x < 9 else "giỏi"

toan = float(input("Nhập điểm toán: "))
li = float(input("Nhập điểm lí: "))
hoa = float(input("Nhập điểm hóa: "))
van = float(input("Nhập điểm văn: "))
anh = float(input("Nhập điểm anh: "))
print("học lực: " +hocluc(diemtrungbinh(toan, li, hoa, van, anh)))

# Viết hàm Python tính tổng các số nguyên tô từ 0 - 1000
def tongsonguyen(a, b):
    sums = 0
    for i in range(a, b):
        sums += i
    return sums

print("tổng: ",tongsonguyen(1, 1001))

# Viết hàm Python tìm giá trị lớn nhất trong 3 số
def solonnhat(a, b, c):
    max = a
    if b > max:
        max = b
    if c > max:
        max = c
    return max 

a = float(input("số a: "))
b = float(input("số b: "))
c = float(input("số c: "))
print("số lớn nhất ",solonnhat(a, b, c))

# Viết hàm Lambda Python in ra thông tin sinh viên
def thongtinsv(name):
    return lambda info: name + ", " + info

ten = input("nhập tên: ")
sv = thongtinsv(ten)

tuoi = input("nhập tuoi: ")
print(sv(tuoi))

gioitinh = input("nhập gioi tinh: ")
print(sv(gioitinh))

quoctich = input("nhập quoc tịch: ")
print(sv(quoctich))


# Viết hàm đệ quy Python tính tổng S = 1 + 2 + 3 + 4 + 5 ... + n
def dequy(n):
    if n == 1:
        return 1
    return dequy(n - 1) + n

n = int(input("n: "))
print(dequy(n))