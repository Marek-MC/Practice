# Creating Variables.
a = "Brrrr!" # String
b = 8 # Integer
c = 4.5 # Float
d = b + c # Integer + Float

IO.puts(a)
IO.puts(b)
IO.puts(c)
IO.puts(d)

# Creating Modules.
defmodule myModule() do
  IO.puts("This is a module.")

  # Creating Functions.
  def myFunc() do
    IO.puts("This is a public function. Can be used globally.")
  end

  defp privateFunc() do
    IO.puts("This is a private function, held and used only by this module.")
  end
end

# Big Fat Error: myModule not imported?? `undefined function myModule/0 (there is no such import)`






# Activating Functions inside Modules.








# Example of Modules, Functions, and Algorithms.

# defmodule Math do
#   def sum(a, b) do
#     do_sum(a, b)
#   end

#   defp do_sum(a, b) do
#     a + b
#   end
# end

# IO.puts Math.sum(1, 2)    #=> 3
# IO.puts Math.do_sum(1, 2) #=> ** (UndefinedFunctionError)
