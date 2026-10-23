## Fixes

- **Code generator** — The build error for an element that a source's concrete type does not have no longer suggests casting the source with an explicit `as`, which cannot help there: `Property nonsense cannot be bound at compile time: Condition has no such element.` The hint stays for a source whose type is not known, abstract (such as `Resource`) or an interface, where a cast to a type that has the element makes the read bindable. (#1820)
