Module TestProgram
    Public Function Main()
        Dim Corpus As List(Of String) = GetDocumentCorpus()

    End Function
    ''' <summary>
    ''' When no lists are available, A mixed corpus of documents 
    ''' </summary>
    ''' <returns></returns>
    Public Function GetDocumentCorpus() As List(Of String)
        ' Load paragraphs based on different topics
        Dim paragraphs As New List(Of String)
        Dim sentences As New List(Of String) From {
            "I love apples.",
            "Bananas are tasty.",
            "I love apples.",
            "I enjoy eating bananas.",
            "Kiwi is a delicious fruit.", "Bananas are tasty.",
            "I love apples.", "I enjoy eating bananas.",
            "Kiwi is a delicious fruit.", "I love apples.",
            "I enjoy eating bananas.",
            "Kiwi is a delicious fruit.", "I love apples.",
            "I enjoy eating bananas.",
            "Kiwi is a delicious fruit.", "Bananas are tasty.", "Fisherman, like to fish in the sea, every the Fisher has fished in every place he is fishing.",
        "the lowest of the lower of the lowered tempo of the music",
        "the higher and highest and",
        "I was running, she ran after me, he was run down, until he was finished",
        "it was the the end came and the party ended."
    }
        ' Computer Science Topics
        paragraphs.Add("Computer Science is the study of computation and information processing.")
        paragraphs.Add("Algorithms and data structures are fundamental concepts in computer science.")
        paragraphs.Add("Computer networks enable communication and data exchange between devices.")
        paragraphs.Add("Artificial Intelligence is a branch of computer science that focuses on creating intelligent machines.")
        paragraphs.Add("Software engineering is the discipline of designing, developing, and maintaining software systems.")

        ' NLP Topics
        paragraphs.Add("Natural Language Processing (NLP) is a subfield of artificial intelligence.")
        paragraphs.Add("NLP techniques enable computers to understand, interpret, and generate human language.")
        paragraphs.Add("Named Entity Recognition (NER) is a common task in NLP.")
        paragraphs.Add("Machine Translation is the task of translating text from one language to another.")
        paragraphs.Add("Sentiment analysis aims to determine the sentiment or opinion expressed in a piece of text.")

        paragraphs.Add("The quick brown fox jumps over the lazy dog.")
        paragraphs.Add("The cat and the dog are best friends.")
        paragraphs.Add("Programming languages are used to write computer programs.")
        paragraphs.Add("Natural Language Processing (NLP) is a subfield of artificial intelligence.")
        paragraphs.Add("Machine learning algorithms can be used for sentiment analysis.")
        ' Train the model on a corpus of text
        Dim trainingData As New List(Of String)
        trainingData.Add("Hello")
        trainingData.Add("Hi there")
        trainingData.Add("How are you?")
        trainingData.Add("What's up?")
        trainingData.Add("I'm doing well, thanks!")
        trainingData.Add("Not too bad, how about you?")
        trainingData.Add("Great! What can I help you with?")
        trainingData.Add("I need some assistance")
        trainingData.Add("Can you provide me with information?")
        trainingData.Add("Sure, what do you need?")
        trainingData.Add("Can you tell me about your services?")
        trainingData.Add("We offer a wide range of services to cater to your needs.")
        trainingData.Add("What are the payment options?")
        trainingData.Add("We accept all major credit cards and PayPal.")
        trainingData.Add("Do you have any ongoing promotions?")
        trainingData.Add("Yes, we have a special discount available for new customers.")
        trainingData.Add("How long does shipping take?")
        trainingData.Add("Shipping usually takes 3-5 business days.")
        trainingData.Add("What is your return policy?")
        trainingData.Add("We offer a 30-day return policy for unused items.")
        trainingData.Add("Can you recommend a good restaurant nearby?")
        trainingData.Add("Sure! There's a great Italian restaurant called 'La Bella Vita' just a few blocks away.")
        trainingData.Add("What movies are currently playing?")
        trainingData.Add("The latest releases include 'Avengers: Endgame' and 'The Lion King'.")
        trainingData.Add("What time does the museum open?")
        trainingData.Add("The museum opens at 9:00 AM.")
        trainingData.Add("How do I reset my password?")
        trainingData.Add("You can reset your password by clicking on the 'Forgot Password' link on the login page.")
        trainingData.Add("What are the system requirements for this software?")
        trainingData.Add("The system requirements are listed on our website under the 'Support' section.")
        trainingData.Add("Can you provide technical support?")
        trainingData.Add("Yes, we have a dedicated support team available 24/7 to assist you.")
        trainingData.Add("What is the best way to contact customer service?")
        trainingData.Add("You can reach our customer service team by phone, email, or live chat.")
        trainingData.Add("How do I cancel my subscription?")
        trainingData.Add("To cancel your subscription, please go to your account settings and follow the instructions.")
        trainingData.Add("What are the available colors for this product?")
        trainingData.Add("The available colors are red, blue, and green.")
        trainingData.Add("Do you offer international shipping?")
        trainingData.Add("Yes, we offer international shipping to select countries.")
        trainingData.Add("Can I track my order?")
        trainingData.Add("Yes, you can track your order by entering the tracking number on our website.")
        trainingData.Add("What is your privacy policy?")
        trainingData.Add("Our privacy policy can be found on our website under the 'Privacy' section.")
        trainingData.Add("How do I request a refund?")
        trainingData.Add("To request a refund, please contact our customer service team with your order details.")
        trainingData.Add("What are the opening hours?")
        trainingData.Add("We are open from Monday to Friday, 9:00 AM to 6:00 PM.")
        trainingData.Add("Is there a warranty for this product?")
        trainingData.Add("Yes, this product comes with a one-year warranty.")
        trainingData.Add("Can I schedule an appointment?")
        trainingData.Add("Yes, you can schedule an appointment by calling our office.")
        trainingData.Add("Do you have any vegetarian options?")
        trainingData.Add("Yes, we have a dedicated vegetarian menu.")
        trainingData.Add("What is your company's mission statement?")
        trainingData.Add("Our mission is to provide high-quality products and excellent customer service.")
        trainingData.Add("How can I apply for a job at your company?")
        trainingData.Add("You can apply for a job by submitting your resume through our online application form.")
        'movie dialogues
        trainingData.Add("Luke: I am your father.")
        trainingData.Add("Darth Vader: Noooo!")
        trainingData.Add("Han Solo: May the Force be with you.")
        trainingData.Add("Princess Leia: I love you.")
        trainingData.Add("Han Solo: I know.")
        trainingData.Add("Yoda: Do or do not. There is no try.")
        trainingData.Add("Obi-Wan Kenobi: You were the chosen one!")
        trainingData.Add("Anakin Skywalker: I hate you!")
        trainingData.Add("Marty McFly: Great Scott!")
        trainingData.Add("Doc Brown: Roads? Where we're going, we don't need roads.")
        trainingData.Add("Tony Stark: I am Iron Man.")
        trainingData.Add("Peter Parker: With great power comes great responsibility.")
        trainingData.Add("Bruce Wayne: I'm Batman.")
        trainingData.Add("Alfred Pennyworth: Why do we fall? So we can learn to pick ourselves up.")
        trainingData.Add("Sherlock Holmes: Elementary, my dear Watson.")
        trainingData.Add("Dr. John Watson: It is a capital mistake to theorize before one has data.")
        trainingData.Add("James Bond: The name's Bond. James Bond.")
        trainingData.Add("Harry Potter: I solemnly swear that I am up to no good.")
        trainingData.Add("Ron Weasley: Bloody hell!")
        trainingData.Add("Hermione Granger: It's LeviOsa, not LevioSA.")
        trainingData.Add("Gandalf: You shall not pass!")
        trainingData.Add("Frodo Baggins: I will take the ring, though I do not know the way.")
        trainingData.Add("Samwise Gamgee: I can't carry it for you, but I can carry you!")
        trainingData.Add("Dumbledore: Happiness can be found even in the darkest of times.")
        trainingData.Add("Severus Snape: Always.")


        paragraphs.AddRange(trainingData)

        Dim inputTexts As String() = {
                "John Doe is a software developer from New York. He specializes in Python programming.",
                "Mary Smith is an artist from Los Angeles. She loves to paint landscapes.",
                "Peter Johnson is a doctor from Chicago. He works at a local hospital.",
                "Sara Williams is a teacher from Boston. She teaches English literature.",
                "David Brown is a musician from Seattle. He plays the guitar in a band.",
                "I am a software developer with 5 years of experience. I have expertise in Python and Java.",
        "As a data scientist, I have a Ph.D. in Machine Learning and 8 years of experience.",
        "I am a web developer skilled in Java and Python. I have worked at Microsoft for 10 years.",
        "I am an electrical engineer with a Master's degree and 8 years of experience in power systems.",
        "As a nurse, I have a Bachelor's degree in Nursing and 5 years of experience in a hospital setting.",
        "I am a graphic designer with expertise in Adobe Photoshop and Illustrator. I have worked freelance for 5 years.",
        "As a teacher, I have a Bachelor's degree in Education and 8 years of experience in primary schools.",
        "I am a mechanical engineer with a Ph.D. in Robotics and 10 years of experience in autonomous systems.",
        "As a lawyer, I have a Juris Doctor degree and 5 years of experience in corporate law.",
        "I am a marketing specialist with expertise in digital marketing and social media management. I have worked at Google for 8 years.",
        "As a chef, I have culinary training and 5 years of experience in high-end restaurants.",
        "I am a financial analyst with a Master's degree in Finance and 8 years of experience in investment banking.",
        "I am a software developer with 5 years of experience. I have expertise in Python and Java.",
        "As a data scientist, I have a Ph.D. in Machine Learning and 8 years of experience.",
        "I am a web developer skilled in Java and Python. I have worked at Microsoft for 10 years.",
        "I am an electrical engineer with a Master's degree and 8 years of experience in power systems.",
        "As a nurse, I have a Bachelor's degree in Nursing and 5 years of experience in a hospital setting.",
        "I am a graphic designer with expertise in Adobe Photoshop and Illustrator. I have worked freelance for 5 years.",
        "As a teacher, I have a Bachelor's degree in Education and 8 years of experience in primary schools.",
        "I am a mechanical engineer with a Ph.D. in Robotics and 10 years of experience in autonomous systems.",
        "As a lawyer, I have a Juris Doctor degree and 5 years of experience in corporate law.",
        "I am a marketing specialist with expertise in digital marketing and social media management. I have worked at Google for 8 years.",
        "As a chef, I have culinary training and 5 years of experience in high-end restaurants.",
        "I am a financial analyst with a Master's degree in Finance and 8 years of experience in investment banking.",
        "I am a software developer with 5 years of experience. I have expertise in Python and Java.",
        "As a data scientist, I have a Ph.D. in Machine Learning and 8 years of experience.",
        "I am a web developer skilled in Java and Python. I have worked at Microsoft for 10 years.",
        "I am an electrical engineer with a Master's degree and 8 years of experience in power systems.",
        "As a nurse, I have a Bachelor's degree in Nursing and 5 years of experience in a hospital setting.",
        "I am a graphic designer with expertise in Adobe Photoshop and Illustrator. I have worked freelance for 5 years.",
        "As a teacher, I have a Bachelor's degree in Education and 8 years of experience in primary schools.",
        "I am a mechanical engineer with a Ph.D. in Robotics and 10 years of experience in autonomous systems.",
        "As a lawyer, I have a Juris Doctor degree and 5 years of experience in corporate law.",
        "I am a marketing specialist with expertise in digital marketing and social media management. I have worked at Google for 8 years.",
        "As a chef, I have culinary training and 5 years of experience in high-end restaurants.",
        "I am a financial analyst with a Master's degree in Finance and 8 years of experience in investment banking."
    }
        paragraphs.AddRange(inputTexts)
        Dim NLP As String = "Natural language processing (NLP) Is a field Of artificial intelligence that focuses On the interaction between computers And humans Using natural language. It combines linguistics, computer science, And machine learning To enable computers To understand, interpret, And generate human language.

Machine learning is a subset of artificial intelligence that deals with the development of algorithms and models that allow computers to learn and make predictions or decisions without being explicitly programmed. It plays a crucial role in various applications, including NLP.

In recent news, researchers at XYZ University have developed a new deep learning algorithm for sentiment analysis in NLP. The algorithm achieved state-of-the-art results on multiple datasets and has the potential to improve various NLP tasks.

Another significant development in the computer science industry is the introduction of GPT-3, a powerful language model developed by OpenAI. GPT-3 utilizes advanced machine learning techniques to generate human-like text and has shown promising results in various language-related tasks.

Key people in the data science and AI industry include Andrew Ng, the founder of deeplearning.ai and a prominent figure in the field of machine learning, and Yann LeCun, the director of AI Research at Facebook and a pioneer in deep learning.

These are just a few examples of the vast field of NLP, machine learning, and the latest developments in the computer science industry."
        paragraphs.Add(NLP)
        paragraphs.AddRange(sentences)
        Return paragraphs
    End Function

End Module
