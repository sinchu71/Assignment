//Create a Git Repository
If you haven't already created a repository on GitHub:

Go to GitHub → Click on New Repository.
Name the repository Assignment (or your preferred name).
Do NOT initialize with a README (we'll do it manually).

//Click Create Repository.
Copy the repository URL (e.g., https://github.com/sinchu71/Assignment.git).


//Set Up Your Local Repository

//(A) If You Don't Have a Local Repository Yet
Run these commands:
cd /path/to/your/project  # Go to your project directory
git init                  # Initialize Git in your project
git remote add origin https://github.com/sinchu71/Assignment.git  # Add remote

//(B) If You Already Cloned It
Navigate to the existing folder:
cd /path/to/your/Assignment
git pull origin main  # Get the latest changes

//Create a New Branch
Run:
git checkout -b feature/profanity-core  # Create and switch to new branch


//Verify the branch:

git branch  # The current branch should be highlighted
Add and Commit Your Changes
To track all your changes:
git add .
git commit -m "Added feature profanity-core"


Push Changes to GitHub

//Push the branch to GitHub:
git push origin feature/profanity-core
Create a Pull Request (PR)

//Go to GitHub → Your Repository (https://github.com/sinchu71/Assignment).
Click Branches → Find feature/profanity-core.
Click Compare & Pull Request.
Add a meaningful title and description.
Click Create Pull Request.
