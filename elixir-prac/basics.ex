# Creating Variables.
variable = "I am a variable."
IO.puts(variable)

# Creating Modules.
defmodule myModule() do
  IO.puts("This is a module.")

  # Creating Functions.
  def myFunc() do
    IO.puts("This is a function.")
  end

  defp privateFunc() do
    IO.puts("This is a private function, held and used only by this module.")
  end
end

# Activating Functions inside Modules.
IO.puts myModule.myFunc();

# I cannot get classes or functions to run properly. only variables with console logging.




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
