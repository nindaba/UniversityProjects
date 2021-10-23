import {Icons} from "./constants/icons.js";
import {QUESTIONS} from "./constants/questions.js"
//setup functions
const getElementById = (id)=> document.getElementById(id);
const getRoot = ()=> document.getRootNode();
const mainApp = getElementById("app");

//node creators fruntions
const createTextNode = (text)=>{
    return document.createTextNode(text);
}
const createTypeNode = (type="div",properties={})=>{
    let node = document.createElement(type);
    Object
    .keys(properties)
    .forEach(key => node[key]= properties[key]);
    return node;
}
const createIcon = (name)=> createTypeNode("i",{className:Icons.FORWARD_ARROW});

const createButton = (name,icon,clickHandeler)=>{
    let lowername = name.replaceAll(" ","");
    lowername = lowername.replace(lowername.charAt(0),lowername.charAt(0).toLowerCase())
    let nextButton = createTypeNode("button",{
        id: lowername,
        className:lowername,
    });
    nextButton.appendChild(createIcon(icon));
    nextButton.appendChild(createTextNode(" "));
    nextButton.appendChild(createTextNode(name));
    document.createElement("div").addEventListener
    nextButton.addEventListener("click",clickHandeler);
    return nextButton;
}

//quiz div creation
const question = (subject,answers=[])=>{
    let questionContainer = createTypeNode("div",{
        id: "question",
        className:"question"
    });
    let subjectNode = createTypeNode("p",{className:"subject"});
    subjectNode.appendChild(createTextNode(subject))
    questionContainer.appendChild(subjectNode);
    answers.map(answer=>{
        let answerNode = createTypeNode("span",{className:"answer"});
        let radioNode = createTypeNode("input",{
            className:"answer",
            value: answer,
            type: "radio",
            name: question,
            className:"radio",
            id: question+answer,
        });
        answerNode.appendChild(radioNode);
        answerNode.addEventListener("click",()=> radioNode.click());
        let answerText = createTypeNode("span",{className:"answerText"});
        answerText.appendChild(createTextNode(" "+answer))
        answerNode.appendChild(answerText)
        return answerNode;
    })
    .forEach(answer=> questionContainer.appendChild(answer));
    return questionContainer;
}
/**
 * question-choice
 * 
 */

/**
* Container div which will be containing:
* Question Card 
* Back & Next buttons
*/
const container = ()=>{
    let currentQuestion = 0;
    //container div creation
    let node = createTypeNode("div",{
        id: "container",
        className:"container"
    });


    //Question div creation
    let questionDiv = question(
        QUESTIONS[currentQuestion].question,
        QUESTIONS[currentQuestion].answers); 

    //next and back buttons creation
    let backButton = createButton("Back",Icons.BACK_ARROW,()=>currentQuestion--);
    let nextButton = createButton("Next",Icons.FORWARD_ARROW,()=>{
        currentQuestion++;

    });

    
    //back and next buttons on the question span button
    let questionButtons = createTypeNode("span",{className:"questionButtons"});
    questionButtons.appendChild(backButton);
    questionButtons.appendChild(nextButton);

    //Questions card and buttons on container
    node.appendChild(questionDiv);
    node.appendChild(questionButtons);
    
    return node;
}

//display to the root
mainApp.appendChild(container());
