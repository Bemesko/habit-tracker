# Habit Tracker

An API for tracking habits written using .NET 7.

This is the first API I created from scratch without following any tutorials. I was inspired by apps such as [Loop Habit Tracker](https://loophabits.org/) and it was pretty fun to wonder how everything was modelled behind the scenes.

Originally I wanted to make a frontend for this as well, but since I'm not focusing on that right now I'll leave this project open for anyone who wants to use it as a basis for their frontend. I'll later publish the service on Docker Hub so you can run it locally without having to install all the .NET tools.

## Model
- Habit: Something that you want to do consistently over a period of time
  - e.g. Going to the gym; Waking up early; Studying a language
- Action: A single instance of a habit that you log into the API and track your consistency
  - e.g. "Went to the gym today"; "Woke up early every day for the past week"

## Endpoints
- `/api/Habits`
  - GET - List all habits
  - POST - Insert a new habit
- `/api/Habits/{id}`
  - GET - Get a single habit
  - PUT - Update habit
  - DELETE - Remove habit
- `/api/Habits/{habitId}/Actions`
  - GET - List all actions from a habit
  - POST - Log a new action for a habit
- `/api/Habits/{habitId}/Actions/{actionId}`
  - GET - Get a single action
  - DELETE - Delete an action

## Checklist

- [X] Draft API endpoints and requests
- [X] Make Habit Endpoints
- [X] Store habits in memory
- [X] Make Actions endpoints
- [ ] Publish service to Docker Hub
- [ ] Persist habits in a database
