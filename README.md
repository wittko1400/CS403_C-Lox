# Chapter Updates for C# Lox Interpreter

## Chapter 1
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

## Chapter 2
Chapter 2 completed, tests from book ran successfully

## Chapter 3
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

## Chapter 4
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
