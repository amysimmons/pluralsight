var possibleCombinationSum = function(arr, n) {
  if (arr.indexOf(n) >= 0) { return true; }
  if (arr[0] > n) { return false; }
  if (arr[arr.length - 1] > n) {
    arr.pop();
    return possibleCombinationSum(arr, n);
  }
  var listSize = arr.length, combinationsCount = (1 << listSize)
  for (var i = 1; i < combinationsCount ; i++ ) {
    var combinationSum = 0;
    for (var j=0 ; j < listSize ; j++) {
      if (i & (1 << j)) { combinationSum += arr[j]; }
    }
    if (n === combinationSum) { return true; }
  }
  return false;
};

//sub component
var StarsFrame = React.createClass({
	render: function(){
		var stars = [];
		for(var i=0; i<this.props.numberOfStars; i++){
			stars.push(
				<span className="glyphicon glyphicon-star"></span>
			)
		}
		return (
			<div id="stars-frame">
				<div className="well">
					{stars}
				</div>
			</div>
		)
	}
});

//sub component
var ButtonFrame = React.createClass({
	render: function(){
		var disabled, button, correct = this.props.correct;
		
		switch(correct){
			case true:
				button = (
					<div id="button-frame">
						<button className="btn btn-success btn-lg"
								onClick={this.props.acceptAnswer}>
							<span className="glyphicon glyphicon-ok"></span>
						</button>
					</div>
				);
				break;
			case false:
				button = (
					<div id="button-frame">
						<button className="btn btn-danger btn-lg">
							<span className="glyphicon glyphicon-remove"></span>
						</button>
					</div>
				);
				break;
			default:
				disabled = (this.props.selectedNumbers.length === 0);
				button = (
					<div id="button-frame">
						<button className="btn btn-primary btn-lg" disabled={disabled} onClick={this.props.checkAnswer}>
							=
						</button>
					</div>
				);
		}
		return (
			<div id="button-frame">
				{button}
				<br /><br />
				<button className="btn btn-warning btn-xs" onClick={this.props.redraw} disabled={this.props.redraws === 0}>
					<span className="glyphicon glyphicon-refresh"></span>
					&nbsp;
					{this.props.redraws}
				</button>
			</div>
		)
	}
});

//sub component
var AnswerFrame = React.createClass({
	render: function(){
		var props = this.props;
		var selectedNumbers = props.selectedNumbers.map(function(i){
			return (
				<span onClick={props.unselectNumber.bind(null, i)}>
					{i}
				</span>
			)
		});
		return (
			<div id="answer-frame">
				<div className="well">
					{selectedNumbers}
				</div>
			</div>
		);
	}
});

//sub component
var NumbersFrame = React.createClass({
	render: function(){
		var numbers = [], 
			className, 
			selectedNumbers = this.props.selectedNumbers,
			selectNumber = this.props.selectNumber,
			usedNumbers = this.props.usedNumbers;
		for(i = 1; i <= 9; i ++){
			//if the number is a selected number, give it a class of selected-true
			className = "number selected-" + (selectedNumbers.indexOf(i)>=0);
			//add a class of used-true or used-false
			className += " used-" + (usedNumbers.indexOf(i)>=0);
			numbers.push(
				//calls the selectNumber method on click and passes in the number
				<div className={className} onClick={selectNumber.bind(null,i)}>{i}</div>
			)
		}
		return (
			<div id="numbers-frame">
				<div className="well">
					{numbers}
				</div>
			</div>
		)
	}
});

//sub-component
var DoneFrame = React.createClass({
	render: function(){
		return (
			<div className="well text-center">
				<h2>{this.props.doneStatus}</h2>
				<button className="btn btn-default"
						onClick={this.props.resetGame}>
					Play again
				</button>
			</div>
		);
	}
});

//main component
var Game = React.createClass({
	getInitialState: function(){
		return {
			//random num between 0 and 9
			numberOfStars: this.randomNumber(),
			selectedNumbers: [],
			usedNumbers: [],
			redraws: 5,
			corrct: null,
			doneStatus: null
		};
	},
	resetGame: function(){
		this.replaceState(this.getInitialState());
	},
	randomNumber: function(){
		return Math.floor(Math.random()*9)+1;
	},
	selectNumber: function(clickedNumber){
		//if the clicked number is not already in the selected numbers, add it
		if(this.state.selectedNumbers.indexOf(clickedNumber) < 0 ){
			this.setState(
				//adds the clicked number to the selected numbers
				{selectedNumbers: this.state.selectedNumbers.concat(clickedNumber),
					correct: null}
			);
		}
	},
	unselectNumber: function(clickedNumber){
		var selectedNumbers = this.state.selectedNumbers,
		indexOfNumber = selectedNumbers.indexOf(clickedNumber);
		//removes the number to unselect from the selected numbers array
		selectedNumbers.splice(indexOfNumber, 1);
		this.setState({selectedNumbers: selectedNumbers,
			correct: null});
	},
	sumOfSelectedNumbers: function(){
		//returns the sum of selected numbers, give it a 0 value if the array is empty
		return this.state.selectedNumbers.reduce(function(p,n){
			return p+n;
		}, 0)
	},
	checkAnswer: function(){
		var correct = this.state.numberOfStars === this.sumOfSelectedNumbers();
		this.setState({correct: correct});
	},
	acceptAnswer: function(){
		var usedNumbers = this.state.usedNumbers.concat(this.state.selectedNumbers);
		this.setState({
			selectedNumbers: [],
			usedNumbers: usedNumbers,
			correct: null,
			numberOfStars: this.randomNumber()
		}, function(){
			this.updateDoneStatus();
		});
	},
	redraw: function(){
		if(this.state.redraws > 0){
			this.setState({
				numberOfStars: this.randomNumber(),
				correct: null,
				selectedNumbers: [],
				redraws: this.state.redraws - 1
			}, function(){
				this.updateDoneStatus();
			});
		}
	},
	possibleSolutions: function(){
		var numberOfStars = this.state.numberOfStars,
			possibleNumbers = [],
			usedNumbers = this.state.usedNumbers;

		//populates the possible numbers array
		for(var i; i<=9; i++){
			if(usedNumbers.indexOf(i)<0){
				possibleNumbers.push(i);
			}
		}
		//does the array of possible numbers have any combination of numbers that sum up to equal the value of the stars?
		return possibleCombinationSum(possibleNumbers, numberOfStars);
	},
	updateDoneStatus: function(){
		if(this.state.usedNumbers.length === 9){
			this.setState({doneStatus: 'Done. Nice!'})
			return;
		}
		if(this.state.redraws === 0 && !this.possibleSolutions()){
			this.setState({doneStatus: 'Game Over!'})
		}
	},
	//passes the selectedNumbers state into the child component AnswerFrame as a property
	//passes the selectNumber function into the child NumberFrame as a property
	render: function(){
		var selectedNumbers = this.state.selectedNumbers,
			numberOfStars = this.state.numberOfStars,
			usedNumbers = this.state.usedNumbers,
			redraws = this.state.redraws,
			correct = this.state.correct,
			doneStatus = this.state.doneStatus,
			bottomFrame;
			if(doneStatus){
				bottomFrame = <DoneFrame 
					doneStatus={doneStatus}
					resetGame={this.resetGame}/>;
			}else{
				bottomFrame = <NumbersFrame 
					selectedNumbers={selectedNumbers} 
					selectNumber={this.selectNumber} 
					usedNumbers={usedNumbers}/>;
			}
		return (
			<div id="game">
				<h2>Play Nine</h2>
				<hr />
				<div className="clearfix">
					<StarsFrame 
						numberOfStars={numberOfStars}/>
					<ButtonFrame 
						selectedNumbers={selectedNumbers} 
						correct={correct} 
						redraws={redraws}
						checkAnswer={this.checkAnswer} 
						acceptAnswer={this.acceptAnswer}
						redraw={this.redraw}/>
					<AnswerFrame 
						selectedNumbers={selectedNumbers} 
						unselectNumber={this.unselectNumber}/>
				</div>
				{bottomFrame}
			</div>
		)
	}
});

React.render(
	<Game />,
	document.getElementById('container')
)