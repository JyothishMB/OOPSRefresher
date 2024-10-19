// See https://aka.ms/new-console-template for more information
using Builder.Lib;

Console.WriteLine("Builer Pattern Demo");

RegistrationDocument registrationDocument = new RegistrationDocument();
ProofSubmissionDocument proofSubmissionDocument = new ProofSubmissionDocument();
AgreementDocument agreementDocument = new AgreementDocument();

DocumentDirector documentDirector = new DocumentDirector();

Document newEmployeeRegistrationDoc = documentDirector.MakeDocument(registrationDocument);
Document idProofSubmissionDocument = documentDirector.MakeDocument(proofSubmissionDocument);
Document accptanceAgreementDocument = documentDirector.MakeDocument(agreementDocument);

Console.WriteLine("=================================");
newEmployeeRegistrationDoc.DisplayDocument();
Console.WriteLine("=================================");
idProofSubmissionDocument.DisplayDocument();
Console.WriteLine("=================================");
accptanceAgreementDocument.DisplayDocument();
Console.WriteLine("=================================");

Console.ReadKey();



