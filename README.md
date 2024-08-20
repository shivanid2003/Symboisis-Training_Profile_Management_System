# Symboisis-Training_Profile_Management_System

---

# Profile Generation Website

This project is part of the Dot Net Training and focuses on building a Profile Generation Website with ASP.NET Core. The website allows users to create profiles for placements (LinkedIn, Indeed), social media (Instagram, Facebook), and matrimonial sites, with features to evaluate the chances of profile selection or popularity.

## Features

- **User Registration & Login**: Secure registration and login system.
- **Profile Creation**: Users can create detailed profiles similar to LinkedIn, Indeed, Instagram, and Facebook.
- **Profile Evaluation**: The website analyzes profiles, matching keywords and requirements to assess the chances of job selection or social media fame.
- **Suggestions & Download**: Based on the analysis, the site suggests improvements and allows users to download the profile in PDF format.
- **Walkthrough Video**: A video guide is available to help users navigate profile creation and downloading.

## Technologies Used

- **Frontend**: HTML, CSS, JavaScript (implemented by me)
- **Backend**: C#, ASP.NET Core
- **Database**: SQL Server (AccuraProfileDb)

## Database Structure

### LinkedIn Profile Table
- `UserID`, `FullName`, `ProfilePicture`, `Email`, `PhoneNumber`, etc.

### Instagram Profile Table
- `AccountID`, `Username`, `Password`, `EmailOrPhone`, `FullName`, etc.

## Analysis & Display

- **Keyword Matching**: Bar charts display keyword matching percentages.
- **Scoring**: Profiles are scored and color-coded to indicate the probability of selection or social media success.

## Installation

1. Clone the repository.
2. Install the required packages:
   - `Microsoft.AspNetCore.Identity.EntityFrameworkCore`
   - `Microsoft.EntityFrameworkCore`
   - `Microsoft.EntityFrameworkCore.SqlServer`
   - `Microsoft.EntityFrameworkCore.Tools`
3. Set up the SQL Server database using the provided SQL scripts.
4. Run the project.

---
