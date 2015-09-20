var Card = React.createClass({
	
	getInitialState: function(){
		return {};
	},
	componentDidMount: function(){
		var component = this;
		$.get("https://api.github.com/users/" + this.props.login, function(data){
			component.setState(data);
		})
	},
	render: function(){
		return(
			<div>
				<img src={this.state.avatar_url} width="100"/>
				<h3>{this.state.login}</h3>
				<hr/>
			</div>
		);
	}
});

var Form = React.createClass({
	handleSubmit: function(e){
		//stops the form from submitting and refreshing the page
		e.preventDefault();
		//grabs the reference added below
		var loginInput = React.findDOMNode(this.refs.login);
		//add card
		this.props.addCard(loginInput.value);
		//reset form input value
		loginInput.value = '';
	},
	render: function(){
		return (
			<form onSubmit={this.handleSubmit}>
				<input placeholder="github login" ref="login"/>
				<button>Add</button>
			</form>
		);
	}
});

var Main = React.createClass({
	getInitialState: function(){
		return {logins: []};
	},
	addCard: function(loginToAdd){
		this.setState({logins: this.state.logins.concat(loginToAdd)});
	},
	render: function(){
		var cards = this.state.logins.map(function(login){
			return (<Card login={login}/>);
		});
		return(
			<div>
				<Form addCard={this.addCard}/>
				{cards}
			</div>
		)
	}
});

React.render(<Main />, document.getElementById("root"));