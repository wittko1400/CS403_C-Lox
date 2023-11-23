# Chapter Updates for C# Lox Interpreter

## Chapter 4
The scanner works as expected and takes in values and triggers errors on unexpected tokens, and unterminated strings

> var a = 10;
VAR var
IDENTIFIER a
EQUAL =
NUMBER 10 10
SEMICOLON ;
EOF
> var b = a + !; // Unexpected character '!'
VAR var
IDENTIFIER b
EQUAL =
IDENTIFIER a
PLUS +
BANG !
SEMICOLON ;
EOF

> var x = 42;
VAR var
IDENTIFIER x
EQUAL =
NUMBER 42 42
SEMICOLON ;
EOF
> var y = "Hello, ";
VAR var
IDENTIFIER y
EQUAL =
STRING "Hello, " Hello,
SEMICOLON ;
EOF
> var z = "world!";
VAR var
IDENTIFIER z
EQUAL =
STRING "world!" world!
SEMICOLON ;
EOF
> print y + z; // Should print "Hello, world!"
PRINT print
IDENTIFIER y
PLUS +
IDENTIFIER z
SEMICOLON ;
EOF

> var str = "This is an unterminated string
[line 1] Error: Unterminated string.
VAR var
IDENTIFIER str
EQUAL =
EOF

## Chapter 5
Chapter 2 completed, tests from book ran successfully

## Chapter 6
Works as expected, tests run and give expected output for programmed parsing
> 2 + 3 * 4
(+ 2 (* 3 4))
> 5 - 2 / 1
(- 5 (/ 2 1))
> 10 * (2 + 3)
(* 10 (group (+ 2 3)))
> true and false
True
> yes
[line 1] Error at 'yes': Expect expression.
> true
True
> false
False
> false and true
False
> false or true
False
> "Hello, " + "world!"
(+ Hello,  world!)
> clear
[line 1] Error at 'clear': Expect expression.
>

## Chapter 7
> (2 + 3) * (4 - 1)
15
> (8 / 2) + (5 * 2)
14
> (15 / 3) + 2
7
> (4 * 6) / 2
12
> (10 - 7) * 2
6

## Chapter 8
> var a = "global a"; var b = "global b"; var c = "global c";
>
> { var a = "outer a"; var b = "outer b"; { var a = "inner a"; print a; print b; print c; } print a; print b; print c; } print a; print b; print c;
inner a
outer b
global c
outer a
outer b
global c
global a
global b
global c
>
> 
## Chapter 9
> for (var i = 0; i < 10; i = i + 1) {print i;}
0
1
2
3
4
5
6
7
8
9
> var a = 0; var temp; for (var b = 1; a < 10000; b = temp + b) {print a; temp = a; a = b;}
0
1
1
2
3
5
8
13
21
34
55
89
144
233
377
610
987
1597
2584
4181
6765
> var a = 2; var b = 0;
> print "Logical AND Result: " + resultAnd; // Should print "Logical AND Result: 0"
Undefined variable 'resultAnd'.
[line 1]
> var resultAnd = a and b;
> print "Logical AND Result: " + resultAnd; // Should print "Logical AND Result: 0"
Operands must be two numbers or two strings.
[line 1]
> var i = 0; while (i < 5) { print i; i = i + 1; }
0
1
2
3
4
> false and true;
> var false = 0;
[line 1] Error at 'false': Expect variable name.
> var no = 0;
> var yes = 1;
> yes and no;
> print yes and no;
0
> print yes or no;
1

## Chapter 10
> "totally not a function"();
Can only call functions and classes.
[line 1]
> fun add(a, b, c) {
[line 1] Error at end: Expect '}' after block.
>   print a + b + c;
Undefined variable 'a'.
[line 1]
> fun makeCounter() {var i = 0; fun count() {i = i + 1; print i;} return count;}
> var counter = makeCounter();
> counter(); // "1".
1
> counter();
2
> counter();
3
>

## Chapter 11
> return "at top level";
[line 1] Error: Can't return from top-level code.
> var a = "outer";
> {var a = a;}
[line 1] Error: Can't read local variable in its own initializer.
> var a = "global";
> {fun showA() {print a;}
[line 1] Error at end: Expect '}' after block.
> {fun showA() {print a;} showA(); var a = "block"; showA();}
global
global
>
