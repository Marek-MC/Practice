-- Initialize main Output.
main :: IO ()

-- Creating Variables: Variables in Haskell should be kept static. 
a = 56
b = 900
c = 9.5
d = a + b 
e = b + c

f = "This is a string."

-- Accessing Variables: You cannot just print any value, you must be explicit which value you're asking for.
main = putStrLn f