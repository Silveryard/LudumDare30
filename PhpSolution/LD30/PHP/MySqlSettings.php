<?php

	class MySqlSettings{
		
		public $Server;
		public $User;
		public $Password;
		public $Database;
		
		public function __construct(){
			$this->Server = 'localhost';
			$this->Password = 'Test';
			$this->User = 'silveryard_LD30';
			$this->Database = 'silveryard_LD30';
		}
		
	}

?>