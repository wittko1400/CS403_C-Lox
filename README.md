# CS403_C-Lox

## Install/Build

## Usage

## Testing
Tests were taken from Robert Nystroms Tetsing repo to test his lox interpreter.
242/242 Tests were successful proving completion and accuracy of the Lox Interpreter.
Test output can be checked against the test file included in the repo to verify accuracy.

###Test Output:
Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\empty_file.lox

Test 1/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\precedence.lox
14
8
4
0
True
True
True
True
0
0
0
0
4

Test 2/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\unexpected_character.lox
[line 3] Error: Unexpected character.
[line 3] Error at 'b': Expect ')' after arguments.

Test 3/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\assignment\associativity.lox
c
c
c

Test 4/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\assignment\global.lox
before
after
arg
arg

Test 5/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\assignment\grouping.lox
[line 2] Error at '=': Invalid assignment target.

Test 6/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\assignment\infix_operator.lox
[line 3] Error at '=': Invalid assignment target.

Test 7/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\assignment\local.lox
before
after
arg
arg

Test 8/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\assignment\prefix_operator.lox
[line 2] Error at '=': Invalid assignment target.

Test 9/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\assignment\syntax.lox
var
var

Test 10/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\assignment\to_this.lox
[line 3] Error at '=': Invalid assignment target.

Test 11/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\assignment\undefined.lox
Undefined variable 'unknown'.
[line 1]

Test 12/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\block\empty.lox
ok

Test 13/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\block\scope.lox
inner
outer

Test 14/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\bool\equality.lox
True
False
False
True
False
False
False
False
False
False
True
True
False
True
True
True
True
True

Test 15/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\bool\not.lox
False
True
True

Test 16/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\call\bool.lox
Can only call functions and classes.
[line 1]

Test 17/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\call\nil.lox
Can only call functions and classes.
[line 1]

Test 18/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\call\num.lox
Can only call functions and classes.
[line 1]

Test 19/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\call\object.lox
Can only call functions and classes.
[line 4]

Test 20/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\call\string.lox
Can only call functions and classes.
[line 1]

Test 21/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\class\empty.lox
Foo

Test 22/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\class\inherited_method.lox
in foo
in bar
in baz

Test 23/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\class\inherit_self.lox
[line 1] Error: A class can't inherit from itself.

Test 24/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\class\reference_self.lox
Foo

Test 25/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\closure\assign_to_closure.lox
local
after f
after f
after g

Test 26/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\closure\assign_to_shadowed_later.lox
inner
assigned

Test 27/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\closure\closed_closure_in_function.lox
local

Test 28/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\closure\close_over_function_parameter.lox
param

Test 29/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\closure\close_over_later_variable.lox
b
a

Test 30/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\closure\close_over_method_parameter.lox
param

Test 31/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\closure\nested_closure.lox
a
b
c

Test 32/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\closure\open_closure_in_function.lox
local

Test 33/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\closure\reference_closure_multiple_times.lox
a
a

Test 34/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\closure\reuse_closure_slot.lox
a

Test 35/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\closure\shadow_closure_with_local.lox
closure
shadow
closure

Test 36/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\closure\unused_closure.lox
ok

Test 37/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\closure\unused_later_closure.lox
a

Test 38/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\comments\line_at_eof.lox
ok

Test 39/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\comments\only_line_comment.lox

Test 40/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\comments\only_line_comment_and_line.lox

Test 41/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\comments\unicode.lox
ok

Test 42/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\constructor\arguments.lox
init
1
2

Test 43/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\constructor\call_init_early_return.lox
init
init
Foo instance

Test 44/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\constructor\call_init_explicitly.lox
Foo.init(one)
Foo.init(two)
Foo instance
init

Test 45/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\constructor\default.lox
Foo instance

Test 46/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\constructor\default_arguments.lox
Expected 0 arguments but got 3.
[line 3]

Test 47/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\constructor\early_return.lox
init
Foo instance

Test 48/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\constructor\extra_arguments.lox
Expected 2 arguments but got 4.
[line 8]

Test 49/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\constructor\init_not_method.lox
not initializer

Test 50/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\constructor\missing_arguments.lox
Expected 2 arguments but got 1.
[line 5]

Test 51/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\constructor\return_in_nested_function.lox
bar
Foo instance

Test 52/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\constructor\return_value.lox
[line 3] Error: Can't return a value from an initializer.

Test 53/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\expressions\evaluate.lox
[line 5] Error at end: Expect ';' after expression.

Test 54/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\expressions\parse.lox
[line 4] Error at end: Expect ';' after expression.

Test 55/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\call_function_field.lox
bar
1
2

Test 56/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\call_nonfunction_field.lox
Can only call functions and classes.
[line 6]

Test 57/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\get_and_set_method.lox
other
1
method
2

Test 58/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\get_on_bool.lox
Only instances have properties.
[line 1]

Test 59/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\get_on_class.lox
Only instances have properties.
[line 2]

Test 60/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\get_on_function.lox
Only instances have properties.
[line 3]

Test 61/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\get_on_nil.lox
Only instances have properties.
[line 1]

Test 62/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\get_on_num.lox
Only instances have properties.
[line 1]

Test 63/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\get_on_string.lox
Only instances have properties.
[line 1]

Test 64/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\many.lox
apple
apricot
avocado
banana
bilberry
blackberry
blackcurrant
blueberry
boysenberry
cantaloupe
cherimoya
cherry
clementine
cloudberry
coconut
cranberry
currant
damson
date
dragonfruit
durian
elderberry
feijoa
fig
gooseberry
grape
grapefruit
guava
honeydew
huckleberry
jabuticaba
jackfruit
jambul
jujube
juniper
kiwifruit
kumquat
lemon
lime
longan
loquat
lychee
mandarine
mango
marionberry
melon
miracle
mulberry
nance
nectarine
olive
orange
papaya
passionfruit
peach
pear
persimmon
physalis
pineapple
plantain
plum
plumcot
pomegranate
pomelo
quince
raisin
rambutan
raspberry
redcurrant
salak
salmonberry
satsuma
strawberry
tamarillo
tamarind
tangerine
tomato
watermelon
yuzu

Test 65/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\method.lox
got method
arg

Test 66/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\method_binds_this.lox
foo1
1

Test 67/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\on_instance.lox
bar value
baz value
bar value
baz value

Test 68/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\set_evaluation_order.lox
Undefined variable 'undefined1'.
[line 1]

Test 69/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\set_on_bool.lox
Only instances have fields.
[line 1]

Test 70/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\set_on_class.lox
Only instances have fields.
[line 2]

Test 71/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\set_on_function.lox
Only instances have fields.
[line 3]

Test 72/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\set_on_nil.lox
Only instances have fields.
[line 1]

Test 73/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\set_on_num.lox
Only instances have fields.
[line 1]

Test 74/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\set_on_string.lox
Only instances have fields.
[line 1]

Test 75/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\field\undefined.lox
Undefined property 'bar'.
[line 4]

Test 76/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\for\class_in_body.lox
[line 2] Error at 'class': Expect expression.

Test 77/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\for\closure_in_body.lox
4
1
4
2
4
3

Test 78/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\for\fun_in_body.lox
[line 2] Error at 'fun': Expect expression.

Test 79/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\for\return_closure.lox
i

Test 80/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\for\return_inside.lox
i

Test 81/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\for\scope.lox
0
-1
after
0

Test 82/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\for\statement_condition.lox
[line 3] Error at '{': Expect expression.
[line 3] Error at ')': Expect ';' after expression.

Test 83/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\for\statement_increment.lox
[line 2] Error at '{': Expect expression.

Test 84/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\for\statement_initializer.lox
[line 3] Error at '{': Expect expression.
[line 3] Error at ')': Expect ';' after expression.

Test 85/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\for\syntax.lox
1
2
3
0
1
2
done
0
1
0
1
2
0
1

Test 86/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\for\var_in_body.lox
[line 2] Error at 'var': Expect expression.

Test 87/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\function\body_must_be_block.lox
[line 3] Error at '123': Expect '{' before function body.

Test 88/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\function\empty_body.lox
nil

Test 89/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\function\extra_arguments.lox
Expected 2 arguments but got 4.
[line 6]

Test 90/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\function\local_mutual_recursion.lox
Undefined variable 'isOdd'.
[line 4]

Test 91/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\function\local_recursion.lox
21

Test 92/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\function\missing_arguments.lox
Expected 2 arguments but got 1.
[line 3]

Test 93/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\function\missing_comma_in_parameters.lox
[line 3] Error at 'c': Expect ')' after parameters.

Test 94/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\function\mutual_recursion.lox
True
True

Test 95/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\function\nested_call_with_arguments.lox
hello world

Test 96/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\function\parameters.lox
0
1
3
6
10
15
21
28
36

Test 97/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\function\print.lox
<fn foo>
Lox_Interpreter.Globals+Clock

Test 98/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\function\recursion.lox
21

Test 99/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\function\too_many_arguments.lox
[line 260] Error at 'a': Can't have more than 255 arguments.

Test 100/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\function\too_many_parameters.lox
[line 257] Error at 'a': Can't have more than 255 parameters.

Test 101/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\if\class_in_else.lox
[line 2] Error at 'class': Expect expression.

Test 102/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\if\class_in_then.lox
[line 2] Error at 'class': Expect expression.

Test 103/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\if\dangling_else.lox
good

Test 104/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\if\else.lox
good
good
block

Test 105/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\if\fun_in_else.lox
[line 2] Error at 'fun': Expect expression.

Test 106/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\if\fun_in_then.lox
[line 2] Error at 'fun': Expect expression.

Test 107/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\if\if.lox
good
block
True

Test 108/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\if\truth.lox
false
nil
True
0
empty

Test 109/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\if\var_in_else.lox
[line 2] Error at 'var': Expect expression.

Test 110/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\if\var_in_then.lox
[line 2] Error at 'var': Expect expression.

Test 111/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\inheritance\constructor.lox
value

Test 112/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\inheritance\inherit_from_function.lox
Superclass must be a class.
[line 3]

Test 113/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\inheritance\inherit_from_nil.lox
Superclass must be a class.
[line 2]

Test 114/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\inheritance\inherit_from_number.lox
Superclass must be a class.
[line 2]

Test 115/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\inheritance\inherit_methods.lox
foo
bar
bar

Test 116/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\inheritance\parenthesized_superclass.lox
[line 4] Error at '(': Expect superclass name.

Test 117/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\inheritance\set_fields_from_base_class.lox
foo 1
foo 2
bar 1
bar 2
bar 1
bar 2

Test 118/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\logical_operator\and.lox
False
1
False
True
3
True
False

Test 119/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\logical_operator\and_truth.lox
False
nil
ok
ok
ok

Test 120/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\logical_operator\or.lox
1
1
True
False
False
False
True

Test 121/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\logical_operator\or_truth.lox
ok
ok
True
0
s

Test 122/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\method\arity.lox
no args
1
3
6
10
15
21
28
36

Test 123/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\method\empty_block.lox
nil

Test 124/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\method\extra_arguments.lox
Expected 2 arguments but got 4.
[line 8]

Test 125/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\method\missing_arguments.lox
Expected 2 arguments but got 1.
[line 5]

Test 126/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\method\not_found.lox
Undefined property 'unknown'.
[line 3]

Test 127/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\method\print_bound_method.lox
<fn method>

Test 128/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\method\refer_to_name.lox
<fn method>

Test 129/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\method\too_many_arguments.lox
[line 259] Error at 'a': Can't have more than 255 arguments.

Test 130/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\method\too_many_parameters.lox
[line 258] Error at 'a': Can't have more than 255 parameters.

Test 131/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\nil\literal.lox
nil

Test 132/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\number\decimal_point_at_eof.lox
[line 2] Error at end: Expect property name after '.'.

Test 133/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\number\leading_dot.lox
[line 2] Error at '.': Expect expression.

Test 134/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\number\literals.lox
123
987654
0
-0
123.456
-0.001

Test 135/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\number\nan_equality.lox
False
True
True
False

Test 136/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\number\trailing_dot.lox
[line 2] Error at ';': Expect property name after '.'.

Test 137/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\add.lox
579
string

Test 138/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\add_bool_nil.lox
Operands must be two numbers or two strings.
[line 1]

Test 139/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\add_bool_num.lox
Operands must be two numbers or two strings.
[line 1]

Test 140/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\add_bool_string.lox
Operands must be two numbers or two strings.
[line 1]

Test 141/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\add_nil_nil.lox
Operands must be two numbers or two strings.
[line 1]

Test 142/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\add_num_nil.lox
Operands must be two numbers or two strings.
[line 1]

Test 143/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\add_string_nil.lox
Operands must be two numbers or two strings.
[line 1]

Test 144/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\comparison.lox
True
False
False
True
True
False
False
False
True
False
True
True
False
False
False
False
True
True
True
True

Test 145/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\divide.lox
4
1

Test 146/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\divide_nonnum_num.lox
Operands must be numbers.
[line 1]

Test 147/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\divide_num_nonnum.lox
Operands must be numbers.
[line 1]

Test 148/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\equals.lox
True
True
False
True
False
True
False
False
False
False

Test 149/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\equals_class.lox
True
False
False
True
False
False
False
False

Test 150/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\equals_method.lox
True
False

Test 151/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\greater_nonnum_num.lox
Operands must be numbers.
[line 1]

Test 152/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\greater_num_nonnum.lox
Operands must be numbers.
[line 1]

Test 153/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\greater_or_equal_nonnum_num.lox
Operands must be numbers.
[line 1]

Test 154/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\greater_or_equal_num_nonnum.lox
Operands must be numbers.
[line 1]

Test 155/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\less_nonnum_num.lox
Operands must be numbers.
[line 1]

Test 156/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\less_num_nonnum.lox
Operands must be numbers.
[line 1]

Test 157/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\less_or_equal_nonnum_num.lox
Operands must be numbers.
[line 1]

Test 158/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\less_or_equal_num_nonnum.lox
Operands must be numbers.
[line 1]

Test 159/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\multiply.lox
15
3.702

Test 160/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\multiply_nonnum_num.lox
Operands must be numbers.
[line 1]

Test 161/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\multiply_num_nonnum.lox
Operands must be numbers.
[line 1]

Test 162/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\negate.lox
-3
3
-3

Test 163/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\negate_nonnum.lox
Operand must be a number.
[line 1]

Test 164/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\not.lox
False
True
True
False
False
True
False
False

Test 165/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\not_class.lox
False
False

Test 166/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\not_equals.lox
False
False
True
False
True
False
True
True
True
True

Test 167/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\subtract.lox
1
0

Test 168/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\subtract_nonnum_num.lox
Operands must be numbers.
[line 1]

Test 169/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\operator\subtract_num_nonnum.lox
Operands must be numbers.
[line 1]

Test 170/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\print\missing_argument.lox
[line 2] Error at ';': Expect expression.

Test 171/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\return\after_else.lox
ok

Test 172/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\return\after_if.lox
ok

Test 173/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\return\after_while.lox
ok

Test 174/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\return\at_top_level.lox
[line 1] Error: Can't return from top-level code.

Test 175/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\return\in_function.lox
ok

Test 176/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\return\in_method.lox
ok

Test 177/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\return\return_nil_if_no_value.lox
nil

Test 178/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\scanning\identifiers.lox
[line 1] Error at 'formless': Expect ';' after expression.

Test 179/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\scanning\keywords.lox
[line 1] Error at 'and': Expect expression.
[line 1] Error at 'else': Expect class name.
[line 1] Error at 'fun': Expect '(' after 'for'.
[line 1] Error at 'nil': Expect '(' after 'if'.
[line 1] Error at 'this': Expect '.' after 'super'.
[line 1] Error at 'while': Expect variable name.

Test 180/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\scanning\numbers.lox
[line 2] Error at '123.456': Expect ';' after expression.

Test 181/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\scanning\punctuators.lox
[line 1] Error at ')': Expect expression.
[line 1] Error at ',': Expect expression.

Test 182/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\scanning\strings.lox
[line 2] Error at '"string"': Expect ';' after expression.

Test 183/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\scanning\whitespace.lox
[line 1] Error at 'tabs': Expect ';' after expression.

Test 184/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\string\error_after_multiline.lox
Undefined variable 'err'.
[line 7]

Test 185/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\string\literals.lox
()
a string
A~¶_??

Test 186/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\string\multiline.lox
1
2
3

Test 187/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\string\unterminated.lox
[line 2] Error: Unterminated string.

Test 188/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\bound_method.lox
A.method(arg)

Test 189/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\call_other_method.lox
Derived.bar()
Base.foo()

Test 190/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\call_same_method.lox
Derived.foo()
Base.foo()

Test 191/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\closure.lox
Base

Test 192/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\constructor.lox
Derived.init()
Base.init(a, b)

Test 193/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\extra_arguments.lox
Derived.foo()
Expected 2 arguments but got 4.
[line 10]

Test 194/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\indirectly_inherited.lox
C.foo()
A.foo()

Test 195/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\missing_arguments.lox
Expected 2 arguments but got 1.
[line 9]

Test 196/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\no_superclass_bind.lox
[line 3] Error: Can't use 'super' in a class with no superclass.

Test 197/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\no_superclass_call.lox
[line 3] Error: Can't use 'super' in a class with no superclass.

Test 198/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\no_superclass_method.lox
Undefined property 'doesNotExist'.
[line 5]

Test 199/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\parenthesized.lox
[line 8] Error at ')': Expect '.' after 'super'.

Test 200/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\reassign_superclass.lox
Base.method()
Base.method()

Test 201/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\super_at_top_level.lox
[line 1] Error: Can't use 'super' outside of a class.
[line 2] Error: Can't use 'super' outside of a class.

Test 202/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\super_in_closure_in_inherited_method.lox
A

Test 203/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\super_in_inherited_method.lox
A

Test 204/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\super_in_top_level_function.lox
[line 1] Error: Can't use 'super' outside of a class.

Test 205/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\super_without_dot.lox
[line 6] Error at ';': Expect '.' after 'super'.

Test 206/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\super_without_name.lox
[line 5] Error at ';': Expect superclass method name.

Test 207/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\super\this_in_superclass_method.lox
a
b

Test 208/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\this\closure.lox
Foo

Test 209/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\this\nested_closure.lox
Foo

Test 210/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\this\this_at_top_level.lox
[line 1] Error: Can't use 'this' outside of a class.

Test 211/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\this\this_in_method.lox
baz

Test 212/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\this\this_in_top_level_function.lox
[line 2] Error: Can't use 'this' outside of a class.

Test 213/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\collide_with_parameter.lox
[line 2] Error: Already a variable with this name in this scope.

Test 214/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\duplicate_local.lox
[line 3] Error: Already a variable with this name in this scope.

Test 215/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\duplicate_parameter.lox
[line 2] Error: Already a variable with this name in this scope.

Test 216/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\early_bound.lox
outer
outer

Test 217/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\in_middle_of_block.lox
a
a b
a c
a b d

Test 218/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\in_nested_block.lox
outer

Test 219/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\local_from_method.lox
variable

Test 220/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\redeclare_global.lox
nil

Test 221/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\redefine_global.lox
2

Test 222/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\scope_reuse_in_different_blocks.lox
first
second

Test 223/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\shadow_and_local.lox
outer
inner

Test 224/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\shadow_global.lox
shadow
global

Test 225/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\shadow_local.lox
shadow
local

Test 226/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\undefined_global.lox
Undefined variable 'notDefined'.
[line 1]

Test 227/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\undefined_local.lox
Undefined variable 'notDefined'.
[line 2]

Test 228/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\uninitialized.lox
nil

Test 229/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\unreached_undefined.lox
ok

Test 230/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\use_false_as_var.lox
[line 2] Error at 'false': Expect variable name.

Test 231/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\use_global_in_initializer.lox
value

Test 232/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\use_local_in_initializer.lox
[line 3] Error: Can't read local variable in its own initializer.

Test 233/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\use_nil_as_var.lox
[line 2] Error at 'nil': Expect variable name.

Test 234/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\variable\use_this_as_var.lox
[line 2] Error at 'this': Expect variable name.

Test 235/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\while\class_in_body.lox
[line 2] Error at 'class': Expect expression.

Test 236/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\while\closure_in_body.lox
1
2
3

Test 237/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\while\fun_in_body.lox
[line 2] Error at 'fun': Expect expression.

Test 238/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\while\return_closure.lox
i

Test 239/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\while\return_inside.lox
i

Test 240/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\while\syntax.lox
1
2
3
0
1
2

Test 241/242 Passed

Running test: C:\Users\wittk\source\repos\Lox_Interpreter\test\while\var_in_body.lox
[line 2] Error at 'var': Expect expression.

Test 242/242 Passed
