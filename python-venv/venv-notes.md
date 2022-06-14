# Create and Use Venv

Create Venv -
`python3 -m venv [name]`

Activate Venv -
`source bin/activate`

Check Current Environment - 
`which python3`, `which pip3`, `python —version`

Deactivate Venv - 
`deactivate`

# Install Dependencies

Install ALL Venv dependencies - 
`pipenv install` or `pipenv install --dev`

Synv Venv dependencies (Safe effect) -
`pipenv sync` or `pipenv sync --dev`

# FYCD, Freeze Your Current Dependencies!

Check your dependencies - 
`pip3 freeze`

Freeze them into text file! - 
`pip3 freeze > requirements.txt`