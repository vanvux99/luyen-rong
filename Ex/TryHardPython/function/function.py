# def function_name(parameters):
#     """docstring"""
#     statement(s)

# function_name(parameters)

def a(name, msg):
    print("Chào ", name, ', ', msg, end=".")

# a('vũ', 'hihi')
# a(name = 'vũ', msg = 'hihi')

def b(*names):
    #This function greets all the person in the names tuple.
    # names is a tuple with arguments
    for name in names:
        print("Hello",name)

b('uchiha', 'áds', 'dfsdf') 

