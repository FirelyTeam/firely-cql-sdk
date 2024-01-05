library CqlErrorsAndMessagingOperatorsTest

context Unfiltered


define "TestMessageInfo Input":
	Message(1, true, '100', 'Message', 'Test Message')
define "TestMessageInfo Output":
	1

define "TestMessageWarn Input":
	Message(2, true, '200', 'Warning', 'You have been warned!')
define "TestMessageWarn Output":
	2

define "TestMessageTrace Input":
	Message({3, 4, 5}, true, '300', 'Trace', 'This is a trace')
define "TestMessageTrace Output":
	{3, 4, 5}

define "TestMessageError":
	Message(3 + 1, true, '400', 'Error', 'This is an error!')
