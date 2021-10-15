#  cú pháp
try:  
    "block of code"
except Exception1:   #except:   có thể để không 
    "#block of code  "
except Exception2:  #except ArithmeticError,StandardError:    khai báo nhiều err 
    "block of code  "
else:  
    "#Đoạn này sẽ chạy nếu except block không chạy"
finally:  
    "# Khối chứa đoạn code # luôn luôn thực thi "

try:
    c = 0/0;  
    # print("a/b = %d"%c)
except ZeroDivisionError:
    print("ZeroDivisionError")


try:  
    fileptr = open("file.txt","r")    
    try:  
        fileptr.write("Nội dung ghi vào file")  
    finally:  
        fileptr.close()  
        print("Đóng file")  
except:  
    print("Mở file lỗi")

try:  
    age = int(input("Nhập tuổi của bạn?"))  
    if age<18:  
        raise ValueError # nhảy thẳng tới except ValueError
    else:  
        print("Tuổi không hợp lệ")  
except ValueError:  
    print("Tuổi quá nhỏ")