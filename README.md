# Assessment2

The assessment's initial code was of low quality : Extensibility & Maintainability would cost more if more messages have to be managed by it.

The solution proposed : 
- Create an abstraction that will insure the treatement,
- All messages should inherit from AbstractMessage
- All common message calls should be defined in the Asbtract methods
- Message Instantiation would be insured by a factory (and would be the only message instantiation point on the code)
- The Console Code should not be touched when it concerns Message treatement (modify only the Message abstraction and the Message Instances)

Feel free to execute the CLI application. It will expose the output of the optimised code
