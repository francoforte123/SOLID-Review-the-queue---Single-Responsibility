using SOLID__Review_the_queue___Single_Responsibility;

FuncQueue<int> funcQueueInteger = new FuncQueue<int>();
FuncDequeue<int> funcDequeueInteger = new FuncDequeue<int>();
FuncPeek<int> funcPeekInteger = new FuncPeek<int>();


funcQueueInteger.Queue(1);
funcQueueInteger.Queue(2);
funcQueueInteger.Queue(3);
funcQueueInteger.Queue(4);


funcDequeueInteger.Dequeue();
funcPeekInteger.Peek();

//-------------------------------------------

FuncQueue<string> funcQueueString = new FuncQueue<string>();
FuncDequeue<string> funcDequeueString = new FuncDequeue<string>();
FuncPeek<string> funcPeekString = new FuncPeek<string>();

funcQueueString.Queue("Marco");
funcQueueString.Queue("Luca");
funcQueueString.Queue("Emanuele");
funcQueueString.Queue("Alberto");

funcDequeueString.Dequeue();
funcPeekString.Peek();
