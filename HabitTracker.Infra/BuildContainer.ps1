docker build `
    -f ..\HabitTracker.Api\Dockerfile `
    -t bemesko/habit-tracker `
    ..

docker push `
    bemesko/habit-tracker
