# PointsBet_Backend_Online_Code_Test
This is a simple folder containing a `StringFormatter.cs` file for code enhancement.

For candidates, please follow the below points to complete the test:
- Read the `README.md` file in the root directory, which should be the same file you are reading now. :)
- Go to the `README.md` file
  - Read the comment in the `StringFormatter.cs` file
  - Follow the instructions in the comment to complete the task
- Once complete your solution, please submit the codebase to your GitHub and share the public link with our HR team

Thank you for completing the code test with PointsBet.

---

## Notes from the candidate

The original method `ToCommaSepatatedList` was renamed to `JoinWithQuotes` to fix a typo and better reflect its behaviour.
The method returns a comma-separated string with quoted items, not a list.

Improvements made:

- Handled null or empty `items` array
- Treated null `quote` as an empty string (no wrapping)
- Trimmed and replaced null items with empty strings
- Quoted and joined items using commas

Escaping inner quote characters is intentionally ommited to stay within the original scope and logic.