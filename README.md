# Habit Tracker

An API for tracking habits

## Endpoints
- /Actions: Something you do that can be tracked
  - GET
  - GET {habitId} - List all actions for a habit
  - POST
  - DELETE
- /Habits: A collection of tracked Actions over time
  - GET - List all habits
  - GET {ID} - Get details for a specific habit
  - POST
  - PUT
  - DELETE

## Checklist

- [X] Draft API endpoints and requests
- [X] Make Habit Endpoints
- [X] Store habits in memory
- [ ] Make Actions endpoints
- [ ] Persist habits in a database
