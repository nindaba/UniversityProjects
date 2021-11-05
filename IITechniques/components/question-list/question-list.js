export class QuestionList{
    // private card
    constructor(
        questions=[{question:"",answers:""}],
        container = document.createElement("div")){
            container.style =`
            display: flex;
            flex-direction: column;
            padding: 2%;
            border: 1px solid var(--primary);
            box-shadow: 1px 1px var(--secondary);
            width: 200px;
            border-radius: 5px;
            margin-left: 15px;
            `
            questions
            .map((question,index) => this.addToList(index,question))
            .forEach(node=> container.appendChild(node))
    }
    addToList(index=0,quest={question:"",answers:""}){
        let node = document.createElement("div");
        node.className = "list";
        node.innerHTML = `${index}. ${quest.question.substr(0,20)}`;
        node.style =`
        display: flex;
        flex-direction: column;
        padding: 2%;
        border-color: var(--primary);
        // box-shadow: 1px 1px var(--secondary);
        width: 200px;
        border-radius: 5px;
        margin-bottom:1%;
        `
        return node;
    }
}