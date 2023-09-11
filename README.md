# Avalonia Billing Logger

All UI for this app is built using [AvaloniaUI] with the backend API built using [FastAPI].

## Goals

1. For the user to be able to add and update bills
2. Allow for the user to be able to add new services (defined as Carriers)
3. Allow for the user to be able to add new products

## Useful Tools

Using [Act] to test github workflows locally, to test workflows work accurately. If you installed using the GitHub CLI, the [act script](./act-workflow.sh) will run all workflows defined. One note with [Act] is that it does not support Windows out of the box.


<!-- References -->
[AvaloniaUI]: https://docs.avaloniaui.net/
[FastAPI]: https://fastapi.tiangolo.com/
[Act]: https://github.com/nektos/act