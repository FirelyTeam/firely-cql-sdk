library CqlErrorsAndMessagingOperatorsTest version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

context Patient

define "TestMessageInfo":
  Message(1, true, '100', 'Message', 'Test Message')= 1

define "TestMessageWarn":
  Message(2, true, '200', 'Warning', 'You have been warned!')= 2

define "TestMessageTrace":
  Message({ 3, 4, 5 }, true, '300', 'Trace', 'This is a trace')= { 3, 4, 5 }

define "TestMessageError":
  Message(3 + 1, true, '400', 'Error', 'This is an error!')