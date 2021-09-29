# Tính tổng S(n) = 1 + 2 + 3 + … + n bằng Python
# number = input("nhập n = ")
# for i in number:
#     sums = int(i)
#     sums += sums
# print(sums)

# Tính tổng S(n) = 1^2 + 2^2 + … + n^2 bằng Python
# number = input("nhập n = ")
# for i in number:
#     sums = int(i)
#     sums += sums ** 2
# print(sums)

# Tính tổng S(n) = 1 + ½ + 1/3 + … + 1/n bằng Python
# number = input("nhập n = ")
# value = 0.0
# for i in range(1, int(number) + 1):
#     value += float(1/i)
# print(value)

# Tính tổng S(n) = ½ + ¼ + … + 1/2n bằng Python
# number = 2# input("nhập n = ")
# value = 0.0
# for i in range(0, int(number) + 1):
#     if i % 2 == 0:
#         value += float(1/(i*2))
# print(value)


# Tính tổng S(n) = 1/3 + 1/5 + … + 1/(2n + 1)
# number = 2# input("nhập n = ")
# value = 0.0
# for i in range(0, int(number) + 1):
#     if i % 2 == 1:
#         value += float(1/(i*2 + 1))
# print(value)

# Liệt kê tất cả các ước số của số nguyên dương n bằng Python
# number = input("nhập n = ")
# stri = ''
# if int(number) > 0:
#     for i in range(1, int(number) + 1):
#         if int(number) % i == 0:
#             stri += str(i) + ' '
# print ("tất cả các ước số của số nguyên dương " + number+ " là: " +stri )

# Tính tổng tất cả các ước số của số nguyên dương N bằng Python
# number = input("nhập n = ")
# stri = 0
# if int(number) > 0:
#     for i in range(1, int(number) + 1):
#         if int(number) % i == 0:
#             stri += i
# print ("tổng các ước số của số nguyên dương " + number + " là: " + str(stri))

# Tìm ước số lẻ lớn nhất của một số bằng Python
# number = input("nhập n = ")
# uln = 0
# if int(number) > 0:
#     for i in range(1, int(number) + 1):
#         if int(number) % i == 0:
#             if i > uln and i % 2 == 1:
#                 uln = i
# print (uln)

