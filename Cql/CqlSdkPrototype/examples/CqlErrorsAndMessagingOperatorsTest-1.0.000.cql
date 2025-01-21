library CqlErrorsAndMessagingOperatorsTest version '1.0.000'

define "undefined.TestMessageInfo": Message(1, true, '100', 'Message', 'Test Message')

define "undefined.TestMessageWarn": Message(2, true, '200', 'Warning', 'You have been warned!')

define "undefined.TestMessageTrace": Message({3, 4, 5}, true, '300', 'Trace', 'This is a trace')

define "undefined.TestMessageError": Message(3 + 1, true, '400', 'Error', 'This is an error!')

