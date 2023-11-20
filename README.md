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
