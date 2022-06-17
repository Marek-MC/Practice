import sys

def main(): # Running main() is the professional way to build a python program.
    try:
        print("PROGRAM ENTRY POINT!!")

    except ValueError as ve:
        return str(ve) # Captures and delivers an error if main() cannot be run.

if __name__ == "__main__": # Send it. 
    sys.exit(main()) # Exit.