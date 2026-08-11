# HelloCash Customer PDF Creator

A small program to speed up PDF creation for existing customers.

## Overview

The PDF templates support the following form fields:

- **CustomerName**
- **CustomerAddress**
- **CustomerPLZCity**
- **CustomerPhone**
- **CustomerEmail**
- **DateBox** — automatically fills with the current date (day-month-year)

## Output

Generated files are named using the pattern:

CustomerFirstName-CustomerLastName-Year-Month-Day

If a file with that name already exists, minutes and seconds are appended to keep the filename unique.
