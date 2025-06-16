library CqlLogicalOperatorsTest version '1.0.000'

define "And.TrueAndTrue": true and true

define "And.TrueAndFalse": true and false

define "And.TrueAndNull": true and null

define "And.FalseAndTrue": false and true

define "And.FalseAndFalse": false and false

define "And.FalseAndNull": false and null

define "And.NullAndTrue": null and true

define "And.NullAndFalse": null and false

define "And.NullAndNull": null and null

define "Implies.TrueImpliesTrue": true implies true

define "Implies.TrueImpliesFalse": true implies false

define "Implies.TrueImpliesNull": true implies null

define "Implies.FalseImpliesTrue": false implies true

define "Implies.FalseImpliesFalse": false implies false

define "Implies.FalseImpliesNull": false implies null

define "Implies.NullImpliesTrue": null implies true

define "Implies.NullImpliesFalse": null implies false

define "Implies.NullImpliesNull": null implies null

define "Not.NotTrue": not true

define "Not.NotFalse": not false

define "Not.NotNull": not null

define "Or.TrueOrTrue": true or true

define "Or.TrueOrFalse": true or false

define "Or.TrueOrNull": true or null

define "Or.FalseOrTrue": false or true

define "Or.FalseOrFalse": false or false

define "Or.FalseOrNull": false or null

define "Or.NullOrTrue": null or true

define "Or.NullOrFalse": null or false

define "Or.NullOrNull": null or null

define "Xor.TrueXorTrue": true xor true

define "Xor.TrueXorFalse": true xor false

define "Xor.TrueXorNull": true xor null

define "Xor.FalseXorTrue": false xor true

define "Xor.FalseXorFalse": false xor false

define "Xor.FalseXorNull": false xor null

define "Xor.NullXorTrue": null xor true

define "Xor.NullXorFalse": null xor false

define "Xor.NullXorNull": null xor null

