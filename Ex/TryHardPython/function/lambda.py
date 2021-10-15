# Chương trình sử dụng lambda python function
double = lambda x: x * 2
 
# Output: 10
# print(double(5))

def myfunc(n):
  return lambda a : a * n
 
# Biến mydoubler lúc này sẽ là một lambda function
mydoubler = myfunc(2)
 
# Vì vậy bạn có thể gọi thoải mái và nhiều lần ở nhièu vị trí
# Và vẫn kế thừa giá trị n của hàm myfunc
# print(mydoubler(11)) # Kết quả 22
# print(mydoubler(10)) # Kết quả 20

def abc (a, b):
    return a * b

# print(abc(2,11))

# viết pt bậc 1 

def phuongtrinhbacnhat(a,b):
  print("phương trình ax + b = 0 có các hệ số lần lượt là: ", a, b)
  if a > 0:
    print("nghiệm của phương trình là: ", -b/a)
  elif a == 0:
    print("phương trình có vô số nghiệm")
  else:
    print("phương trình vô nghiệm")

a = float(input("nhập hệ số a: "))
b = float(input("nhập hệ số b: "))
phuongtrinhbacnhat(a,b)

phuongtrinhbacnhat2 = lambda a, b: ("vô nghiệm" if a < 0 else -b/a) if a != 0 else "vô số nghiệm"
print('phương trình có nghiệm: ', phuongtrinhbacnhat2(a,b))

# pt = lambda a,b: ( () if a < 0 else ) if a != 0 else "vô nghiệm"